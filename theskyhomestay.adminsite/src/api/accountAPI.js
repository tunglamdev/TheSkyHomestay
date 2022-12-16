import API from "./API";

const accountAPI = {
  Login: (request) => {
    return API.post("/Users/Login", request);
  },
}

export default accountAPI;