import React, { useState, useEffect } from 'react';
import { Line } from 'react-chartjs-2';
import { CDBContainer } from 'cdbreact';
import Tab from 'react-bootstrap/Tab';
import Tabs from 'react-bootstrap/Tabs';
import { Button } from "reactstrap";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Table from 'react-bootstrap/Table';
import DatePicker from 'react-datepicker';
import "react-datepicker/dist/react-datepicker.css";
import Col from 'react-bootstrap/Col';
import Nav from 'react-bootstrap/Nav';
import Row from 'react-bootstrap/Row';
import bookingApi from "../../api/bookingAPI";
import * as xlsx from "xlsx";

function Statistic() {
    const [revenueByDate, setRevenueByDate] = useState([]);
    const [revByDate, setRevByDate] = useState(0);
    const [numberOfCheckingByDate, setNumberOfCheckingByDate] = useState(0);

    const [revenueByMonth, setRevenueByMonth] = useState([]);
    const [revByMonth, setRevByMonth] = useState(0);
    const [numberOfCheckingByMonth, setNumberOfCheckingByMonth] = useState(0);

    const [revenueByQuarter, setRevenueByQuarter] = useState([]);
    const [revByQuarter, setRevByQuarter] = useState(0);
    const [numberOfCheckingByQuarter, setNumberOfCheckingByQuarter] = useState(0);

    const [revenueByYear, setRevenueByYear] = useState([]);
    const [revByYear, setRevByYear] = useState(0);
    const [numberOfCheckingByYear, setNumberOfCheckingByYear] = useState(0);

    const [selectedDate, setSelectedDate] = useState(null);
    const [selectedMonth, setSelectedMonth] = useState(null);
    const [selectedYearByQuarter, setSelectedYearByQuarter] = useState(null);
    const [selectedYear, setSelectedYear] = useState(null);

    const { register, handleSubmit } = useForm();


    const getByDate = async (content) => {
        content = new Date(selectedDate);
        content.setDate(content.getDate() + 1);
        content = content.toISOString();
        content = content.slice(0, content.indexOf("T"));

        var data = await bookingApi.GetRevenueByDate(content);
        data.bookingList.forEach(element => {
            element.checkInDate = new Date(element.checkInDate);
            element.checkInDate = element.checkInDate.toLocaleDateString("vi-VN");
        });

        setRevenueByDate(data);
        setRevByDate(data.revenue);
        setNumberOfCheckingByDate(data.numberOfChecking);
    }

    const getByMonth = async () => {
        var date = new Date(selectedMonth);
        var month = date.getMonth() + 1;
        var year = date.getFullYear();
        var data = await bookingApi.GetRevenueByMonth(month, year);
        data.bookingList.forEach(element => {
            element.checkInDate = new Date(element.checkInDate);
            element.checkInDate = element.checkInDate.toLocaleDateString("vi-VN");
        });

        setRevenueByMonth(data);
        setRevByMonth(data.revenue);
        setNumberOfCheckingByMonth(data.numberOfChecking);
    }

    const getByQuarter = async (content) => {
        var date = new Date(selectedYearByQuarter);
        var year = date.getFullYear();
        var data = await bookingApi.GetRevenueByQuarter(year, content.Quarter);
        data.bookingList.forEach(element => {
            element.checkInDate = new Date(element.checkInDate);
            element.checkInDate = element.checkInDate.toLocaleDateString("vi-VN");
        });
        console.log(data);
        setRevenueByQuarter(data);
        setRevByQuarter(data.revenue);
        setNumberOfCheckingByQuarter(data.numberOfChecking);
    }

    const getByYear = async () => {
        var date = new Date(selectedYear);
        var year = date.getFullYear();
        var data = await bookingApi.GetRevenueByYear(year);
        data.bookingList.forEach(element => {
            element.checkInDate = new Date(element.checkInDate);
            element.checkInDate = element.checkInDate.toLocaleDateString("vi-VN");
        });

        setRevenueByYear(data);
        setRevByYear(data.revenue);
        setNumberOfCheckingByYear(data.numberOfChecking);
    }

    const formatter = new Intl.NumberFormat('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });

    //Chart
    const [checkInStatistic, setCheckInStatistic] = useState({});
    const [revenueStatistic, setRevenueStatistic] = useState({});
    useEffect(() => async () => {
        var content = {
            labels: [],
            datasets: [
                {
                    label: 'Số lượt check-in',
                    fill: false,
                    lineTension: 0.1,
                    backgroundColor: 'rgb(10, 189, 243)',
                    borderColor: 'rgb(10, 189, 243)',
                    borderCapStyle: 'butt',
                    borderDash: [],
                    borderDashOffset: 0.0,
                    borderJoinStyle: 'miter',
                    pointBorderColor: 'rgba(75,192,192,1)',
                    pointBackgroundColor: '#fff',
                    pointBorderWidth: 1,
                    pointHoverRadius: 5,
                    pointHoverBackgroundColor: 'rgba(71, 225, 167, 0.5)',
                    pointHoverBorderColor: 'rgb(71, 225, 167)',
                    pointHoverBorderWidth: 2,
                    pointRadius: 1,
                    pointHitRadius: 10,
                    data: [],
                },
            ],
        }
        const result = await bookingApi.CheckInStatistic();
        result?.map(r => {
            content.labels.push("Tháng " + r.month);
            content.datasets[0].data.push(r.numberOfBooking);
        });
        setCheckInStatistic(content);
    }, []);

    useEffect(() => async () => {
        var content = {
            labels: [],
            datasets: [
                {
                    label: 'Doanh thu (VND)',
                    fill: false,
                    lineTension: 0.1,
                    backgroundColor: '#dc3545',
                    borderColor: '#dc3545',
                    borderCapStyle: 'butt',
                    borderDash: [],
                    borderDashOffset: 0.0,
                    borderJoinStyle: 'miter',
                    pointBorderColor: '#dc3545',
                    pointBackgroundColor: '#fff',
                    pointBorderWidth: 1,
                    pointHoverRadius: 5,
                    pointHoverBackgroundColor: '#dc3545',
                    pointHoverBorderColor: '#dc3545',
                    pointHoverBorderWidth: 2,
                    pointRadius: 1,
                    pointHitRadius: 10,
                    data: [],
                },
            ],
        }
        const result = await bookingApi.RevenueStatistic();
        result?.map(r => {
            content.labels.push("Tháng " + r.month);
            content.datasets[0].data.push(r.revenue);
        });
        setRevenueStatistic(content);
    }, []);

    //Export XLSX file
    const handleOnExportRevenueByDate = () =>{
        var wb = xlsx.utils.book_new(),
        ws = xlsx.utils.json_to_sheet(JSON.parse(JSON.stringify(revenueByDate.bookingList)));
        xlsx.utils.book_append_sheet(wb, ws, "Sheet1");
        xlsx.writeFile(wb, "Thongke.xlsx");
    }

    const handleOnExportRevenueByMonth = () =>{
        var wb = xlsx.utils.book_new(),
        ws = xlsx.utils.json_to_sheet(JSON.parse(JSON.stringify(revenueByMonth.bookingList)));
        xlsx.utils.book_append_sheet(wb, ws, "Sheet1");
        xlsx.writeFile(wb, "Thongke.xlsx");
    }

    const handleOnExportRevenueByQuarter = () =>{
        var wb = xlsx.utils.book_new(),
        ws = xlsx.utils.json_to_sheet(JSON.parse(JSON.stringify(revenueByQuarter.bookingList)));
        xlsx.utils.book_append_sheet(wb, ws, "Sheet1");
        xlsx.writeFile(wb, "Thongke.xlsx");
    }

    const handleOnExportRevenueByYear = () =>{
        var wb = xlsx.utils.book_new(),
        ws = xlsx.utils.json_to_sheet(JSON.parse(JSON.stringify(revenueByYear.bookingList)));
        xlsx.utils.book_append_sheet(wb, ws, "Sheet1");
        xlsx.writeFile(wb, "Thongke.xlsx");
    }
    return (
        <div>
            <div style={{ flex: "1 1 auto", display: "flex", flexFlow: "column", height: "100vh", overflowY: "hidden" }}>
                <div style={{ height: "100%" }}>
                    <div style={{ padding: "20px 5%", height: "calc(100% - 64px)", overflowY: "scroll" }}>
                        <div style={{ gridTemplateColumns: "repeat(1, minmax(200px, 700px))" }}>
                            <div className="mt-5 w-100">
                                <h4 className="font-weight-bold mb-3">Doanh thu và lượt check-in</h4>
                                <Tabs
                                    defaultActiveKey="revenue"
                                    id="uncontrolled-tab-example"
                                    className="mb-3"
                                >
                                    <Tab eventKey="revenue" title="Thống kê doanh thu & lượt đến">
                                        <Tab.Container id="left-tabs-example" defaultActiveKey="first">
                                            <Row>
                                                <Col sm={3}>
                                                    <Nav variant="pills" className="flex-column">
                                                        <Nav.Item>
                                                            <Nav.Link eventKey="byDay">Theo ngày</Nav.Link>
                                                        </Nav.Item>
                                                        <Nav.Item>
                                                            <Nav.Link eventKey="byMonth">Theo tháng</Nav.Link>
                                                        </Nav.Item>
                                                        <Nav.Item>
                                                            <Nav.Link eventKey="byQuarter">Theo quý</Nav.Link>
                                                        </Nav.Item>
                                                        <Nav.Item>
                                                            <Nav.Link eventKey="byYear">Theo năm</Nav.Link>
                                                        </Nav.Item>
                                                    </Nav>
                                                </Col>
                                                <Col sm={9}>
                                                    <Tab.Content>
                                                        <Tab.Pane eventKey="byDay">
                                                            <Form onSubmit={handleSubmit(getByDate)}>
                                                                <Table>
                                                                    <thead>
                                                                        <tr>
                                                                            <th>Chọn ngày cần thống kê:</th>
                                                                            <th>
                                                                                <Form.Group>
                                                                                    <DatePicker
                                                                                        selected={selectedDate}
                                                                                        onChange={(date) => setSelectedDate(date)}
                                                                                    // minDate={new Date()}
                                                                                    />
                                                                                </Form.Group>
                                                                            </th>
                                                                            <th>
                                                                                <Button className="me-2" color="success">Xem kết quả</Button>
                                                                            </th>
                                                                        </tr>
                                                                    </thead>
                                                                </Table>
                                                            </Form>
                                                            <Button className="me-2" color="secondary" onClick={handleOnExportRevenueByDate}>Xuất file (.XLSX)</Button>
                                                            <Table className="mt-3" striped bordered hover>
                                                                <thead>
                                                                    <tr>
                                                                        <th>#</th>
                                                                        <th>Tên du khách</th>
                                                                        <th>CMND/CCCD</th>
                                                                        <th>Ngày check-in</th>
                                                                        <th>Tổng thanh toán</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    {revenueByDate.bookingList?.map((booking, key) => (
                                                                        <tr>
                                                                            <td>{key + 1}</td>
                                                                            <td>{booking.touristName}</td>
                                                                            <td>{booking.ciNo}</td>
                                                                            <td>{booking.checkInDate}</td>
                                                                            <td>{formatter.format(booking.total)}</td>
                                                                        </tr>
                                                                    ))}
                                                                </tbody>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng lượt check-in:</th>
                                                                    <th>{numberOfCheckingByDate} lượt</th>
                                                                </tr>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng doanh thu trong ngày:</th>
                                                                    <th>{formatter.format(revByDate)}</th>
                                                                </tr>
                                                            </Table>
                                                        </Tab.Pane>
                                                        <Tab.Pane eventKey="byMonth">
                                                            <Form onSubmit={handleSubmit(getByMonth)}>
                                                                <Table>
                                                                    <thead>
                                                                        <tr>
                                                                            <th>Chọn tháng cần thống kê:</th>
                                                                            <th>
                                                                                <Form.Group>
                                                                                    <DatePicker
                                                                                        selected={selectedMonth}
                                                                                        onChange={(month) => setSelectedMonth(month)}
                                                                                        showMonthYearPicker
                                                                                        dateFormat="MM/yyyy"
                                                                                    />
                                                                                </Form.Group>
                                                                            </th>
                                                                            <th>
                                                                                <Button className="me-2" color="success">Xem kết quả</Button>
                                                                            </th>
                                                                        </tr>
                                                                    </thead>
                                                                </Table>
                                                            </Form>
                                                            <Button className="me-2" color="secondary" onClick={handleOnExportRevenueByMonth}>Xuất file (.XLSX)</Button>
                                                            <Table className="mt-3" striped bordered hover>
                                                                <thead>
                                                                    <tr>
                                                                        <th>#</th>
                                                                        <th>Tên du khách</th>
                                                                        <th>CMND/CCCD</th>
                                                                        <th>Ngày check-in</th>
                                                                        <th>Tổng thanh toán</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    {revenueByMonth.bookingList?.map((booking, key) => (
                                                                        <tr>
                                                                            <td>{key + 1}</td>
                                                                            <td>{booking.touristName}</td>
                                                                            <td>{booking.ciNo}</td>
                                                                            <td>{booking.checkInDate}</td>
                                                                            <td>{formatter.format(booking.total)}</td>
                                                                        </tr>
                                                                    ))}
                                                                </tbody>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng lượt check-in:</th>
                                                                    <th>{numberOfCheckingByMonth} lượt</th>
                                                                </tr>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng doanh thu trong tháng:</th>
                                                                    <th>{formatter.format(revByMonth)}</th>
                                                                </tr>
                                                            </Table>
                                                        </Tab.Pane>
                                                        <Tab.Pane eventKey="byQuarter">
                                                            <Form onSubmit={handleSubmit(getByQuarter)}>
                                                                <Table>
                                                                    <thead>
                                                                        <tr>
                                                                            <th>Chọn quý cần thống kê:</th>
                                                                            <th>
                                                                                Chọn năm:
                                                                                <Form.Group>
                                                                                    <DatePicker
                                                                                        selected={selectedYearByQuarter}
                                                                                        onChange={(year) => setSelectedYearByQuarter(year)}
                                                                                        showYearPicker
                                                                                        dateFormat="yyyy"
                                                                                    />
                                                                                </Form.Group>
                                                                            </th>
                                                                            <th>
                                                                                <Form.Select {...register("Quarter")}>
                                                                                    <option value="1">Quý I</option>
                                                                                    <option value="2">Quý II</option>
                                                                                    <option value="3">Quý III</option>
                                                                                    <option value="4">Quý IV</option>
                                                                                </Form.Select>
                                                                            </th>
                                                                            <th>
                                                                                <Button className="me-2" color="success">Xem kết quả</Button>
                                                                            </th>
                                                                        </tr>
                                                                    </thead>
                                                                </Table>
                                                            </Form>
                                                            <Button className="me-2" color="secondary" onClick={handleOnExportRevenueByQuarter}>Xuất file (.XLSX)</Button>
                                                            <Table className="mt-3" striped bordered hover>
                                                                <thead>
                                                                    <tr>
                                                                        <th>#</th>
                                                                        <th>Tên du khách</th>
                                                                        <th>CMND/CCCD</th>
                                                                        <th>Ngày check-in</th>
                                                                        <th>Tổng thanh toán</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    {revenueByQuarter.bookingList?.map((booking, key) => (
                                                                        <tr>
                                                                            <td>{key + 1}</td>
                                                                            <td>{booking.touristName}</td>
                                                                            <td>{booking.ciNo}</td>
                                                                            <td>{booking.checkInDate}</td>
                                                                            <td>{formatter.format(booking.total)}</td>
                                                                        </tr>
                                                                    ))}
                                                                </tbody>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng lượt check-in:</th>
                                                                    <th>{numberOfCheckingByQuarter} lượt</th>
                                                                </tr>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng doanh thu trong quý:</th>
                                                                    <th>{formatter.format(revByQuarter)}</th>
                                                                </tr>
                                                            </Table>
                                                        </Tab.Pane>
                                                        <Tab.Pane eventKey="byYear">
                                                            <Form onSubmit={handleSubmit(getByYear)}>
                                                                <Table>
                                                                    <thead>
                                                                        <tr>
                                                                            <th>Chọn năm cần thống kê:</th>
                                                                            <th>
                                                                                <Form.Group>
                                                                                    <DatePicker
                                                                                        selected={selectedYear}
                                                                                        onChange={(year) => setSelectedYear(year)}
                                                                                        showYearPicker
                                                                                        dateFormat="yyyy"
                                                                                    />
                                                                                </Form.Group>
                                                                            </th>
                                                                            <th>
                                                                                <Button className="me-2" color="success">Xem kết quả</Button>
                                                                            </th>
                                                                        </tr>
                                                                    </thead>
                                                                </Table>
                                                            </Form>
                                                            <Button className="me-2" color="secondary" onClick={handleOnExportRevenueByYear}>Xuất file (.XLSX)</Button>
                                                            <Table className="mt-3" striped bordered hover>
                                                                <thead>
                                                                    <tr>
                                                                        <th>#</th>
                                                                        <th>Tên du khách</th>
                                                                        <th>CMND/CCCD</th>
                                                                        <th>Ngày check-in</th>
                                                                        <th>Tổng thanh toán</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    {revenueByYear.bookingList?.map((booking, key) => (
                                                                        <tr>
                                                                            <td>{key + 1}</td>
                                                                            <td>{booking.touristName}</td>
                                                                            <td>{booking.ciNo}</td>
                                                                            <td>{booking.checkInDate}</td>
                                                                            <td>{formatter.format(booking.total)}</td>
                                                                        </tr>
                                                                    ))}
                                                                </tbody>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng lượt check-in:</th>
                                                                    <th>{numberOfCheckingByYear} lượt</th>
                                                                </tr>
                                                                <tr>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th></th>
                                                                    <th>Tổng doanh thu trong năm:</th>
                                                                    <th>{formatter.format(revByYear)}</th>
                                                                </tr>
                                                            </Table>
                                                        </Tab.Pane>
                                                    </Tab.Content>
                                                </Col>
                                            </Row>
                                        </Tab.Container>
                                    </Tab>
                                    <Tab eventKey="booking" title="Xem biểu đồ">
                                        <Tab.Container id="left-tabs-example" defaultActiveKey="first">
                                            <Row>
                                                <Col sm={3}>
                                                    <Nav variant="pills" className="flex-column">
                                                        <Nav.Item>
                                                            <Nav.Link eventKey="checkinChart">Biểu đồ lượt Check-in</Nav.Link>
                                                        </Nav.Item>
                                                        <Nav.Item>
                                                            <Nav.Link eventKey="revenueChart">Biểu đồ doanh thu</Nav.Link>
                                                        </Nav.Item>
                                                    </Nav>
                                                </Col>
                                                <Col sm={9}>
                                                    <Tab.Content>
                                                            <Tab.Pane eventKey="checkinChart">
                                                                <CDBContainer>
                                                                    <Line data={checkInStatistic} options={{ responsive: true }} />
                                                                </CDBContainer>
                                                            </Tab.Pane>

                                                            <Tab.Pane eventKey="revenueChart">
                                                                <CDBContainer>
                                                                    <Line data={revenueStatistic} options={{ responsive: true }} />
                                                                </CDBContainer>
                                                            </Tab.Pane>
                                                    </Tab.Content>
                                                </Col>
                                            </Row>
                                        </Tab.Container>
                                    </Tab>
                                </Tabs>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Statistic;