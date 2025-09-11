import { defineConfig } from 'vite';
export default defineConfig({
  base: '/landing_page/',
  build: {
    outDir: 'dist',
    emptyOutDir: true,
  },
});