import API from "./API";

const roomImageAPI = {
  GetById: (id) => {
    return API.get(`Images/${id}`);
  },
  Create: (request) => {
    return API.post("Images",request);
  },
  Delete: (id) => {
    return API.delete(`Images/${id}`);
  }
}

export default roomImageAPI;