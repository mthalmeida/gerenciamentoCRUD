/*****************************************************************/
/*                    CRIA TABELA PESSOA                         */
/*****************************************************************/

CREATE TABLE PESSOA (
    PE_CD INT PRIMARY KEY,
    PE_DS VARCHAR(100) NOT NULL,
    PE_DOCUMENTO CHAR(11) NOT NULL,
    PE_LOGIN VARCHAR(50) NOT NULL,
    PE_SENHA VARCHAR(255) NOT NULL,
    PE_DT_NASCIMENTO DATE,
    PE_TELEFONE VARCHAR(15),
    PE_EMAIL VARCHAR(100),
    PE_ENDERECO VARCHAR(200)
);

CREATE GENERATOR GEN_PE_CD;

SET TERM ^^ ;
CREATE TRIGGER TR_PE_CD FOR PESSOA
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
    IF (NEW.PE_CD IS NULL) THEN
        NEW.PE_CD = GEN_ID(GEN_PE_CD, 1);
END ^^
SET TERM ; ^^
COMMIT;

/*****************************************************************/
/*                     CRIA TABELA LOGS                          */
/*****************************************************************/

CREATE TABLE LOGS (
    LOG_CD INT PRIMARY KEY,
    LOG_USUARIO VARCHAR(50) NOT NULL,
    LOG_DATA_HORA TIMESTAMP NOT NULL,
    LOG_ROTINA VARCHAR(100) NOT NULL,
    LOG_DESCRICAO VARCHAR(255) 
);

CREATE GENERATOR GEN_LOG_CD;

SET TERM ^^ ;
CREATE TRIGGER TR_LOG_CD FOR LOGS
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
    IF (NEW.LOG_CD IS NULL) THEN
        NEW.LOG_CD = GEN_ID(GEN_LOG_CD, 1);
END ^^
SET TERM ; ^^
COMMIT;
