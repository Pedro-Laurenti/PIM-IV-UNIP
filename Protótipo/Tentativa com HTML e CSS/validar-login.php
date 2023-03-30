<?php
  if (!isset($_POST['usuario']) || empty($_POST['usuario'])) {
    echo "Por favor, preencha o campo de usuário.";
    exit;
  }

  if (!isset($_POST['senha']) || empty($_POST['senha'])) {
    echo "Por favor, preencha o campo de senha.";
    exit;
  }

  // Simula a validação de autenticação com usuário e senha
  $usuario = $_POST['usuario'];
  $senha = $_POST['senha'];
  if ($usuario === 'admin' && $senha === '123') {
    echo 'OK';
  } else {
    echo 'Usuário ou senha inválidos.';
  }
?>