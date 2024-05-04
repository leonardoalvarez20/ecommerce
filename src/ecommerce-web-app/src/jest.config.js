module.exports = {
    collectCoverage: true,
    collectCoverageFrom: [
        "src/**/*.{js,jsx,ts,tsx}", // Include all JS/TSX files in src for coverage
        "!src/**/*.test.{js,jsx,ts,tsx}", // Exclude all test files
        "!src/index.js", // Exclude specific files like entry points
        "!src/serviceWorker.js", // Exclude service worker file
        "!src/setupTests.js", // Exclude setup files for tests
        "!**/node_modules/**", // Exclude all files within node_modules
        "!**/vendor/**", // Optionally exclude vendor folder
        "!src/api/**", // Exclude specific directories completely, e.g., API mocks
    ],
    coveragePathIgnorePatterns: [
        "src/jest.config.js"
    ],
    coverageReporters: ["json", "lcov", "text", "text-summary"], // Define reporters
    coverageThreshold: {
        global: { // Optional: Define coverage thresholds
            branches: 50,
            functions: 50,
            lines: 50,
            statements: 50
        }
    }
};
