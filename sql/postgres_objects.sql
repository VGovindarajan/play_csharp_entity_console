-- DROP TABLE customer;

CREATE TABLE customer
(
  id SERIAL PRIMARY KEY,
  firstname character varying(32) NOT NULL,
  lastname character varying(32) NOT NULL,
  address character varying(256) NOT NULL
);
