import API from "./API";

const userAPI = {
  GetAll: () => {
    return API.get("/Users");
  },
  GetById: (id) => {
    return API.get(`/Users/${id}`);
  },
  Create: (request) => {
    return API.post("/Users",request);
  },
  Edit: (request) => {
    return API.put("/Users",request);
  },
  Delete: (id) => {
    return API.delete(`/Users/${id}`);
  }
}

export default userAPI;