DROP TABLE usuario
DROP TABLE restaurant
DROP TABLE comida
DROP TABLE categoria_comida
DROP TABLE menu
DROP TABLE pedido

CREATE TABLE usuario
(
    nombre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    edad integer NOT NULL,
    tipo character varying(1) COLLATE pg_catalog."default" NOT NULL,
    usuario character varying(20) COLLATE pg_catalog."default" NOT NULL,
    passw character varying(30) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT usuario_pkey PRIMARY KEY (usuario)
)

CREATE TABLE restaurant
(
    nombre character varying(30) COLLATE pg_catalog."default" NOT NULL,
    direccion character varying(50) COLLATE pg_catalog."default" NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT restaurant_pkey PRIMARY KEY (id)
)

CREATE TABLE comida
(
    nombre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    categoria integer NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT "Comida_pkey" PRIMARY KEY (id),
    CONSTRAINT comida_categoria FOREIGN KEY (categoria)
        REFERENCES public.categoria_comida (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

CREATE TABLE categoria_comida
(
    nombre character varying COLLATE pg_catalog."default" NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT categoria_comida_pkey PRIMARY KEY (id)
)

CREATE TABLE menu
(
    restaurant integer NOT NULL,
    comida integer NOT NULL,
    precio integer NOT NULL,
    CONSTRAINT menu_pkey PRIMARY KEY (comida, restaurant),
    CONSTRAINT comida FOREIGN KEY (comida)
        REFERENCES public.comida (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT restaurant FOREIGN KEY (restaurant)
        REFERENCES public.restaurant (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

CREATE TABLE pedido
(
    cliente character varying(20) COLLATE pg_catalog."default" NOT NULL,
    detalle character varying(300) COLLATE pg_catalog."default" NOT NULL,
    monto integer NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT pedido_pkey PRIMARY KEY (id)
)

INSERT INTO usuario(nombre, edad, tipo, usuario, passw)VALUES ( , , , , );

INSERT INTO restaurant(nombre, direccion, ) VALUES ( , );

INSERT INTO comida(nombre, categoria) VALUES ( , );

INSERT INTO categoria_comida(nombre) VALUES ( );

INSERT INTO menu(restaurant, comida, precio) VALUES ( , , );

INSERT INTO pedido(cliente, detalle, monto) VALUES ( , , );