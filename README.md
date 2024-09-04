# Postagens API

### Projeto treinamento

### Caso de uso

- Eu como usuário quero publicar postagens organizando as mesmas por meio de categorias e tags para melhor filtrar e destacar os assuntos abordados.  

#### CRUD's

[] Tag's
[] Lista de registros, com opções para deletar e ir para edição do registro
[] Cadastro sendo o nome único no registro de tag's
[] Edição do registro (Usaremos angularJS para consultar os dados a serem editados e também para popular o campo nome)

[] Categorias
	[] Lista de registros, com opções para deletar e ir para edição do registro
	[] Cadastro sendo o nome único no registro de categorias
	[] Edição do registro (Usaremos angularJS para consultar os dados a serem editados e para popular o campo nome)

[] Publicação (Post)
	[] Lista de registros, com opções para deletar e ir para edição do registro
	[] Cadastro sendo o obrigatório vinculo de uma categoria e ao menos uma tag, a tag sendo uma lista podendo o post está vinculado a varias tags (Usaremos o angularJS para consutlar a lista de categorias e montar o select, assim como a lista de tag)
	[] Edição do registro (Usaremos angularJS para consultar os dados a serem editados e também para popularmos os campos)