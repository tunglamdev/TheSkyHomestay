import API from "./API";

const roomAPI = {
  GetAll: () => {
    return API.get("/Rooms");
  },
  GetById: (id) => {
    return API.get(`/Rooms/${id}`);
  },
  Create: (request) => {
    return API.post("/Rooms",request);
  },
  Edit: (request) => {
    return API.put("/Rooms",request);
  },
  Delete: (id) => {
    return API.delete(`/Rooms/${id}`);
  },
  Check: (request) => {
    return API.post(`/Rooms/GetByChecking`, request);
  },
  GetBookingDetail: (request) => {
    return API.post(`/Rooms/GetBookingDetail`, request);
  }
}

export default roomAPI;