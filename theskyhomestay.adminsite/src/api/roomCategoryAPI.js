import API from "./API";

const roomCategoryAPI = {
  GetAll: () => {
    return API.get("/RoomCategories");
  },
  GetById: (id) => {
    return API.get(`/RoomCategories/${id}`);
  },
  Create: (request) => {
    return API.post("/RoomCategories",request);
  },
  Edit: (request) => {
    return API.put("/RoomCategories",request);
  },
  Delete: (id) => {
    return API.delete(`/RoomCategories/${id}`);
  }
}

export default roomCategoryAPI;