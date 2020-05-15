import axios from 'axios';

const instance = axios.create({
    baseURL: 'https://burger-builder-app-9d32b.firebaseio.com/'
});

export default instance;
