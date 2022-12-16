import API from "./API";

const userAPI = {
  GetAllMember: () => {
    return API.get("/Users/Members");
  },
  GetAllGuest: () => {
    return API.get("/Users/Guests");
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