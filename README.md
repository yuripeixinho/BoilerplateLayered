```plaintext
/ Solucao
   / 01.TF.WebApi        → Camada de apresentação (Controllers, Configuração da API)
   / 02.TF.Manager       → Camada intermediária para regras de negócio e serviços
   / 03.TF.Data          → Camada de acesso a dados (Contexto do EF, Repositórios)
   / 04.TF.Core          → Contém o Domínio (Entidades, Regras de negócio)
   / 05.TF.Core.Shared   → Compartilhamento entre módulos
   / 06.TF.Tests         → Testes unitários e de integração
```
