# Ambiente_VR_WEB3.0

## Nome do Aluno
Wagner Cardozo

---

# Apresentando o Projeto

Midnight Microwave é uma pequena experiência interativa feita na Unity utilizando Meta XR SDK como base do projeto.

O ambiente criado foi uma cozinha navegável em primeira pessoa onde o jogador pode interagir com alguns objetos, como abrir a geladeira, pegar uma pizza congelada e utilizar o micro-ondas.

A ideia original do projeto era ser uma experiência mais completa e humorística: o jogador acordaria de madrugada para esquentar comida escondido e precisaria parar o micro-ondas antes do momento exato em que ele apitasse. Caso demorasse demais, aconteceria um “game over” envolvendo o clássico cenário de “levar uma chinelada da mãe”.

A intenção era criar uma situação simples, reconhecível e engraçada usando interação em primeira pessoa e objetos do ambiente.

Durante o desenvolvimento algumas partes precisaram ser simplificadas, mas a base da ideia original foi mantida, servindo assim como um protótipo.

---

# Contexto e Objetivos

O projeto foi pensado dentro da proposta de entretenimento em ambientes XR e Metaverso, focando em uma experiência simples e interativa.

O principal objetivo foi praticar:
- navegação em ambientes 3D;
- interação com objetos;
- uso do Meta XR SDK;
- organização de um projeto Unity;
- desenvolvimento de interações utilizando C#.

Em vez de criar apenas uma cena parada, a ideia foi montar um ambiente onde o jogador pudesse realmente interagir com os objetos da cozinha e entender rapidamente a proposta da experiência.

Mesmo sendo algo simples, tentei criar um cenário reconhecível e com personalidade própria.

---

# Processo de Criação e Dificuldades

O projeto começou inicialmente com foco total em VR utilizando:
- Meta XR SDK;
- XR Simulator;
- Building Blocks da Meta;
- Hand Tracking;
- sistemas de grab/interação em VR.

A ideia original era que toda a interação fosse feita diretamente em realidade virtual utilizando as mãos virtuais e os controles do simulador.

Porém, durante o desenvolvimento apareceram muitos problemas envolvendo:
- interação dos objetos;
- funcionamento do grab;
- XR Simulator;
- compatibilidade entre Unity 6 e alguns sistemas do Meta SDK;
- inconsistências nos Building Blocks.

Em vários momentos algumas interações funcionavam parcialmente, mas quebravam outras partes do projeto, principalmente envolvendo pegar objetos, colisão e interação dentro do simulador.

Por causa do tempo disponível e da necessidade de garantir uma entrega estável, decidi simplificar parte do escopo e adaptar o projeto para funcionar diretamente no Editor/Desktop utilizando:
- movimentação em primeira pessoa;
- raycast para interação;
- sistema simples de pegar e soltar objetos.

Essa mudança permitiu focar mais na estabilidade do projeto e menos em problemas específicos do simulador VR.

Mesmo simplificando algumas ideias originais, consegui manter:
- o ambiente completo;
- a navegação;
- as principais interações;
- a personalidade inicial do projeto.

Os commits anteriores do repositório mostram parte do processo inicial focado em VR antes da adaptação para desktop.

---

# Interações Presentes no Projeto

- Movimentação em primeira pessoa;
- Controle de câmera com mouse;
- Sistema de interação por raycast;
- Destaque visual em objetos interagíveis;
- Texto de ajuda para interação;
- Abertura da geladeira;
- Sistema de pegar e soltar objetos;
- Sistema de encaixe da comida no micro-ondas.

---

# Tecnologias Utilizadas

- Unity 6000.3.13f1 LTS
- C#
- Meta XR SDK
- XR Plugin Management
- GitHub

---

# Considerações Finais

O projeto serviu principalmente como aprendizado prático sobre:
- estruturação de projetos XR;
- lógica de interação;
- organização de cena;
- resolução de problemas durante desenvolvimento;
- adaptação de escopo durante produção.

Apesar das simplificações necessárias durante o processo, o projeto conseguiu manter sua proposta principal e se transformar em uma experiência jogável, interativa e estável dentro do prazo disponível.
