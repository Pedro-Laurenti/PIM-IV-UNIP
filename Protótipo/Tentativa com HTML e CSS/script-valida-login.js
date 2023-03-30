// Obtém o formulário
const form = document.querySelector('form');

// Define uma função para validar o formulário
function validarFormulario(event) {
  // Previne o envio do formulário antes da validação
  event.preventDefault();

  // Obtém os campos do formulário
  const usuario = form.querySelector('#usuario');
  const senha = form.querySelector('#senha');

  // Verifica se os campos estão preenchidos
  if (!usuario.value && !senha.value) {
    exibirMensagemErro('Por favor, preencha os campos de usuário e senha.');
    return;
  } else if (!usuario.value) {
    exibirMensagemErro('Por favor, preencha o campo de usuário.');
    return;
  } else if (!senha.value) {
    exibirMensagemErro('Por favor, preencha o campo de senha.');
    return;
  }

  // Envia uma requisição AJAX para o script PHP
  const xhr = new XMLHttpRequest();
  xhr.open('POST', 'validar-login.php');
  xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
  xhr.onload = function() {
    if (xhr.status === 200) {
      if (xhr.responseText === 'OK') {
        // Se a validação do PHP for bem-sucedida, envia o formulário
        form.submit();
      } else {
        // Se a validação do PHP falhar, exibe uma mensagem de erro
        exibirMensagemErro('Usuário ou senha inválidos.');
      }
    }
  };
  xhr.send(new FormData(form));
}

// Define uma função para exibir uma mensagem de erro
function exibirMensagemErro(mensagem) {
  const form = document.querySelector('form');
  const errorMessage = document.createElement('div');
  errorMessage.id = 'error-message';
  errorMessage.textContent = mensagem;
  form.prepend(errorMessage);
  errorMessage.classList.add('show');
  setTimeout(function() {
    errorMessage.classList.remove('show');
  }, 20000);
}

// Adiciona um evento de submit ao formulário
form.addEventListener('submit', validarFormulario);