import axios from 'axios';

import { env } from '../../env';

export const apiClient = axios.create({
	baseURL: env.api_url,
	headers: {
		'Content-Type': 'application/json'
	}
});

// Add request interceptor for logging
apiClient.interceptors.request.use(
	(config) => {
		console.log('Request:', config.method?.toUpperCase(), config.url);
		return config;
	},
	(error) => {
		console.error('Request Error:', error);
		return Promise.reject(error);
	}
);

// Add response interceptor for logging
apiClient.interceptors.response.use(
	(response) => {
		console.log('Response:', response.status, response.config.url);
		return response;
	},
	(error) => {
		console.error('Response Error:', error.response?.status, error.config?.url);
		return Promise.reject(error);
	}
);
