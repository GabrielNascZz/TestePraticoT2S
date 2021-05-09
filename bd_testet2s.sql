create DATABASE bd_testet2s;
use bd_testet2s;
CREATE TABLE tb_container(
    cd_container INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nm_cliente_container varchar(50) NOT NULL,
    nm_controle_container VARCHAR(11) NOT NULL,
    nm_tipo_container varchar(2) NOT NULL,
    nm_status_container varchar(5) NOT NULL,
    nm_categoria_container varchar(1) NOT NULL
);
create table tb_movimentacao(
	cd_movimentacao int not null primary key auto_increment,
    nm_navio_movimentacao varchar(50) not null,
    nm_tipo_movimentacao varchar(25) not null,
    nm_inicio_movimentacao varchar(30) not null,
    nm_fim_movimentacao varchar(30) not null,
    cd_container varchar(11),
    CONSTRAINT fk_container_movimentacao FOREIGN KEY (cd_container) REFERENCES tb_container (cd_container)
);