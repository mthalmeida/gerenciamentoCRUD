﻿# Sistema de Gerenciamento de Cadastro

Este é um sistema de gerenciamento de cadastro desenvolvido em **C#** no **Visual Studio 2022**, com **Firebird 3.0** como banco de dados. O sistema permite realizar o cadastro de novos usuários, realizar login com senha utilizando criptografia, gerar relatórios com todos os registros cadastrados, controlar logs das rotinas executadas e realizar a exclusão de usuários.

## Funcionalidades

- **Cadastro de Novo Usuário**: Permite que novos usuários sejam cadastrados no sistema. A senha e login são criptografados antes de serem armazenados no banco de dados.
  
- **Login e Senha Criptografados com Base64**: Realiza o login de usuários já cadastrados, utilizando autenticação por login e senha, sendo que a senha e login são verificados após serem criptografados.

- **Relatório de Registros**: Geração de um relatório completo de todos os usuários cadastrados utilizando o **Microsoft Report Viewer (RDLC)**.

- **Controle de Logs**: O sistema mantém um log das rotinas executadas, permitindo o rastreamento de ações como login, cadastro, e exclusão de usuários.

- **Exclusão de Usuários**: Permite a exclusão de usuários cadastrados, removendo suas informações do sistema de forma segura.

- **Duplicação de Usuários**: Permite a duplicação de usuários já cadastrados, copiando suas informações de um registro para outro de forma segura.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Ambiente de Desenvolvimento**: Visual Studio 2022
- **Banco de Dados**: Firebird 3.0
- **Relatórios**: Microsoft Report Viewer (RDLC)
- **Criptografia**: Algoritmos de criptografia Base64

## Licença

Este projeto é licenciado sob a Licença MIT.
