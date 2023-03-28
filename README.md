# PIM-IV-UNIP

# Tutorial: Adicionando um novo arquivo corrigido ao repositório Github pelo CMD

Para adicionar um novo arquivo corrigido ao repositório Github pelo CMD (linha de comando), siga os seguintes passos:

1. Abra o terminal (CMD) e navegue até o diretório do seu repositório local usando o comando `cd` (change directory). Por exemplo:

```cd C:\Users\NomeDoUsuario\Documents\MeuRepositorio```

2. Certifique-se de que você está na branch correta usando o comando `git branch`. Por exemplo:

```git branch```

Isso mostrará todas as branches disponíveis e a branch atual será destacada com um asterisco (*).

3. Certifique-se de que seu repositório local está sincronizado com o repositório remoto usando o comando `git pull`. Por exemplo:

```git pull origin NomeDaBranch```

Isso irá sincronizar o repositório local com o repositório remoto.

4. Adicione o arquivo corrigido usando o comando `git add`. Por exemplo:

```git add NomeDoArquivoCorrigido```

Você também pode adicionar vários arquivos ao mesmo tempo usando o comando `git add .` (adiciona todos os arquivos modificados).

5. Confirme as mudanças usando o comando `git commit`. Por exemplo:

```git commit -m "Mensagem de confirmação"```

Substitua "Mensagem de confirmação" com uma mensagem que descreva as alterações feitas.

6. Envie as alterações para o repositório remoto usando o comando `git push`. Por exemplo:

```git push origin NomeDaBranch```

Isso irá enviar as alterações para o repositório remoto na branch especificada.

Agora o seu novo arquivo corrigido foi adicionado ao repositório Github pelo CMD. Lembre-se de que esses comandos são apenas um exemplo e podem variar dependendo da sua configuração específica.

---

Caso haja necessidade, atualize a sua pasta local utilizando o `Pull`:

```git pull origin NomeDaBranch```

Substitua "NomeDaBranch" pelo nome da branch que você deseja sincronizar com o repositório remoto. Se você não especificar a branch, o Git irá tentar sincronizar com a branch atual.
