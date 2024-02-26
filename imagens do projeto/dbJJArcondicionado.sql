-- Cria o banco de dados
CREATE DATABASE IF NOT EXISTS dbJJArcondicionado;

-- Seleciona o banco de dados criado
USE dbJJArcondicionado;

-- Cria a tabela Usuario
CREATE TABLE IF NOT EXISTS Usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    senha VARCHAR(100) NOT NULL
);