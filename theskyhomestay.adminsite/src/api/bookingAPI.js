import API from "./API";

const bookingAPI = {
  CheckInStatistic: () => {
    return API.get("/Bookings/CheckInStatistic");
  },
  RevenueStatistic: () => {
    return API.get("/Bookings/RevenueStatistic");
  },
  GetRevenueByDate: (date) => {
    return API.get(`/Bookings/Revenue/GetByDate/${date}`);
  },
  GetRevenueByMonth: (month, year) => {
    return API.get(`/Bookings/Revenue/GetByMonth/${month}/${year}`);
  },
  GetRevenueByQuarter: (year, quarter) => {
    return API.get(`/Bookings/Revenue/GetByQuarter/${year}/${quarter}`);
  },
  GetRevenueByYear: (year) => {
    return API.get(`/Bookings/Revenue/GetByYear/${year}`);
  },
}

export default bookingAPI;