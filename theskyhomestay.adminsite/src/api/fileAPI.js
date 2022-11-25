import API from "./API.File";

const fileApi = {
  Upload: (content, folder) => {
    return API.post(`/Files/${folder}`,content);
  },
  Delete: (folder, fileName) => {
    return API.delete(`/Files/${folder}/${fileName}`);
  }
}

export default fileApi;