import { apiClient } from './axios';

export interface Temperature {
	id: number;
	value: number;
	time: string;
}

export const weatherService = {
	async getTemperatures(): Promise<Temperature[]> {
		const response = await apiClient.get<Temperature[]>('/temperatures');
		return response.data;
	},

	async addTemperature(temp: number): Promise<Temperature> {
		const response = await apiClient.post<Temperature>('/temperatures', temp);
		return response.data;
	},

	async getById(id: number): Promise<Temperature> {
		const response = await apiClient.get<Temperature>(`/temperatures/${id}`);
		return response.data;
	},

	async deleteTemperature(id: number): Promise<void> {
		await apiClient.delete(`/temperatures/${id}`);
	}
};
