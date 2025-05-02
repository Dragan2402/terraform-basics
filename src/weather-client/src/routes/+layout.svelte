<script lang="ts">
	import '../app.css';

	let { children } = $props();
</script>

<div class="flex h-screen w-full flex-col items-center justify-center bg-gray-100">
	{@render children()}
</div>
