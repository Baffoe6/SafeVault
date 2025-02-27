// SanitizeInputs.js
function sanitizeInput(input) {
    const sanitized = input.replace(/[^a-zA-Z0-9]/g, "");
    return sanitized;
}

// Example usage for username and email
const username = sanitizeInput(document.getElementById("username").value);
const email = sanitizeInput(document.getElementById("email").value);
