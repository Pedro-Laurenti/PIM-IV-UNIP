const form = document.getElementById("login-form");
const emailInput = document.getElementById("email");
const passwordInput = document.getElementById("password");

form.addEventListener("submit", (event) => {
	event.preventDefault();

	const errorMessage2 = document.getElementById("error-message2");
	const successMessage = document.getElementById("success-message");

	const emailValue = emailInput.value;
	const passwordValue = passwordInput.value;

	const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
	const passwordRegex = /.{8,}/;

	if (!emailRegex.test(emailValue)) {
		console.log("Email inválido!");
		errorMessage2.textContent = "Por favor, digite um e-mail válido.";
		errorMessage2.classList.add("show");
		return;
	}

	if (!passwordRegex.test(passwordValue)) {
		console.log("Senha inválida!");
		errorMessage2.textContent = "Por favor, digite uma senha com pelo menos 8 caracteres.";
		errorMessage2.classList.add("show");
		return;
	}

	console.log("Formulário enviado!");
    errorMessage2.textContent = "Formulário enviado!";
	errorMessage2.classList.remove("show");
	successMessage.classList.add("show");
	form.submit();
});
