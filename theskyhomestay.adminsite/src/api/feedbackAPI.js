import API from "./API";

const feedbackAPI = {
  GetAll: () => {
    return API.get("/Feedbacks");
  },
  Delete: (id) => {
    return API.delete(`/Feedbacks/${id}`);
  }
}

export default feedbackAPI;