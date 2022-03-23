


create table produtos (
codigo int unsigned auto_increment not null primary key,
nome varchar(80) not null,
tamanho varchar(30) not null,
quantidade int not null,
descricao varchar(500),
preco double(9,2) not null,
foto VARCHAR(150) NULL DEFAULT 'C:\\\\Users\\\\FREDERICO REZENDE\\\\Pictures\\\\semfoto.png' 
)engine=InnoDB;


 -- sistema feita de cadastro e login falta exibir no perfil do usuario
 
 create table usuarios(
	codigo int unsigned  auto_increment  not null primary key,
	email varchar(50) not null, 
	senha varchar(50) not null,
    nome varchar(80) not null,
	cpf char(14) not null,
	tipo varchar(50) not null,
	cidade varchar(40),
	estado varchar(40),
	bairro varchar(40),
	rua varchar(40),
	numero varchar(4),
	cep char(14)
    )engine=innodb;
    
    create table clientes(
codigo int unsigned auto_increment not null,
nome varchar(80) not null,
endereco varchar(45) not null,
cidade varchar(45) not null ,
email varchar(100) not null,
idade int unsigned not null,
primary key(codigo)
)engine=innodb;

create table vendas(
numero int unsigned auto_increment not null,
data_entrega date not null,
data_venda date not null,
valor double(9,2) not null,
Clientes_codigo integer  unsigned not null,
Usuarios_codigo int unsigned not null,
tipo varchar(50),
primary key(numero),
foreign key (Clientes_codigo) references clientes(codigo),
foreign key (Usuarios_codigo) references usuarios(codigo)
)engine=innodb;
create table itens_vendas(
codigo integer unsigned auto_increment not null,
quantidade integer unsigned not null,
valor_unitario double(9,2) not null,
Vendas_numero int unsigned not null,
Produtos_codigo integer unsigned not null,
nome varchar(80) not null,
primary key(codigo),
foreign key(Vendas_numero) references vendas(numero),
foreign key(Produtos_codigo) references produtos(codigo)
)engine=innodb;
