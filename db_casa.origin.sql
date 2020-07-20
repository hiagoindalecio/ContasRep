drop database if exists db_casa;
create database db_casa;
use db_casa;

create table tb_moradores(
	id_morador int auto_increment,
	nome varchar(50) not null,
	ativo boolean,
	primary key (id_morador)
);

insert into tb_moradores values
(0,'Hiago', true),
(0,'JJokiba', true),
(0,'Zé', true);

create table tb_data(
	id_data int auto_increment,
	mes int not null,
	ano int not null,
	quantia_total float not null,
	quantia_recebida float,
	primary key (id_data)
);
insert into tb_data values
(0, 4, 2020, 0, 0, 0),
(0, 5, 2020, 0, 0, 0);

create table tb_pagamentos(
	id_pagamento int auto_increment,
	id_morador int not null,
	id_data int not null,
	valor_designado float not null,
	valor_pago float,
	primary key (id_pagamento)
);
alter table tb_pagamentos
add constraint FK_Pagamento_Morador
foreign key (id_morador) references tb_moradores(id_morador);
alter table tb_pagamentos
add constraint FK_Pagamento_Data
foreign key (id_data) references tb_data(id_data);

create table tb_contas(
	id_conta int auto_increment,
	id_data int not null,
	nome_conta varchar(50) not null,
	valor_conta float not null,
	primary key (id_conta)
);
alter table tb_contas
add constraint FK_conta_mes
foreign key (id_data) references tb_data(id_data);
insert into tb_contas values
(0, 1, 'energia', 187.50),
(0, 1, 'agua', 50.00);