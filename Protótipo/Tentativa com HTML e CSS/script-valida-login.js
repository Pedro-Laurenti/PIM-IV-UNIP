document.querySelector('form').addEventListener('submit', function(event) {
    // Previne o envio do formulário antes da validação
    event.preventDefault();

    // Envia uma requisição AJAX para o script PHP
    const xhr = new XMLHttpRequest();
    xhr.open('POST', 'validar-login.php');
    xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    xhr.onload = function() {
        if (xhr.status === 200) {
            if (xhr.responseText === 'OK') {
                // Se a validação do PHP for bem-sucedida, envia o formulário
                document.querySelector('form').submit();
            } else if (xhr.responseText.trim() !== '') {
                // Se a validação do PHP falhar, exibe uma mensagem de erro
                const mensagemErro = document.createElement('div');
                mensagemErro.id = 'error-message';
                mensagemErro.textContent = xhr.responseText;
                document.querySelector('form').prepend(mensagemErro);
            }
        }
    };
    xhr.send(new FormData(document.querySelector('form')));
});