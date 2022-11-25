import API from "./API";

const serviceAPI = {
  GetAll: () => {
    return API.get("/Services");
  },
  GetById: (id) => {
    return API.get(`/Services/${id}`);
  },
  Create: (request) => {
    return API.post("/Services",request);
  },
  Edit: (request) => {
    return API.put("/Services",request);
  },
  Delete: (id) => {
    return API.delete(`/Services/${id}`);
  }
}

export default serviceAPI;