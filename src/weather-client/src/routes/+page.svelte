<script lang="ts">
	import { weatherService, type Temperature } from '$lib/api/weather';
	import { onMount } from 'svelte';

	let temperatures = $state<Temperature[]>([]);
	let newTemperature = $state<number>(0);

	onMount(() => {
		fetchTemperatures();
	});

	const fetchTemperatures = async () => {
		const response = await weatherService.getTemperatures();
		temperatures = response;
	};

	const handleDelete = async (id: number) => {
		await weatherService.deleteTemperature(id);
		fetchTemperatures();
	};

	const handleAddTemperature = async () => {
		await weatherService.addTemperature(newTemperature);
		fetchTemperatures();
	};
</script>

<div class="mx-auto flex h-screen w-[80%] flex-col items-center justify-start bg-gray-50 shadow-lg">
	<div class="h-fit w-1/2 rounded-lg p-4 text-center">
		<h1 class="text-2xl font-bold">Weather App</h1>
	</div>

	<div class="mt-10 flex w-full flex-col items-center gap-y-4 pb-4">
		<h2 class="text-xl font-medium">Temperatures:</h2>

		<div class="flex w-[50%] flex-col gap-2">
			<div class="flex flex-row items-center justify-between gap-x-4 rounded-xl border p-2">
				<p>Value</p>
				<p>Time</p>
				<p>Delete</p>
			</div>
			{#each temperatures as temperature}
				<div class="flex flex-row items-center justify-between gap-x-4 rounded-xl border p-2">
					<p>{temperature.value}</p>
					<p>{new Date(temperature.time).toLocaleString()}</p>
					<button
						class="cursor-pointer rounded-md bg-red-500 px-4 py-2 text-white"
						onclick={() => handleDelete(temperature.id)}
					>
						Delete
					</button>
				</div>
			{/each}
		</div>

		<div class="mx-auto mt-4 flex w-[50%] flex-row gap-2">
			<input
				type="number"
				class="w-full rounded-xl border text-right"
				bind:value={newTemperature}
			/>
			<button
				class="cursor-pointer rounded-md bg-blue-500 px-4 py-2 text-white"
				onclick={handleAddTemperature}
			>
				Add
			</button>
		</div>
	</div>
</div>
