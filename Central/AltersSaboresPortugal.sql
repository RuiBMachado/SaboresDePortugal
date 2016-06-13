Use SaboresPortugalDB;
alter table Tarefa 
alter column datainicial nvarchar(200)
alter table Tarefa 
alter column datafim nvarchar(200);
alter table Tarefa 
alter column idUtilizador int NULL;
alter table Restaurante
alter column longitude float
// adicionei url à tabela foto