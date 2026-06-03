# programacao-aweb
## ⚖️ Funcionalidade: Cálculo de IMC (Server-Side)

Nesta etapa do projeto, foi desenvolvida uma ferramenta completa para cálculo do Índice de Massa Corporal (IMC), seguindo o padrão arquitetural ASP.NET Core MVC. O grande objetivo desta atividade foi processar e validar as informações inteiramente no lado do servidor (**Server-Side**), garantindo que a lógica de negócio fique protegida no controlador.

### 🧠 O que foi programado e como funciona:

1. **O Modelo (`Models/Imc.cs`):** Criamos uma classe para representar os dados do IMC. Nela, foram aplicadas regras de validação estruturadas (`Data Annotations`). Isso garante que o usuário não envie o formulário em branco ou digite valores absurdos (como um peso negativo ou uma altura maior que 3 metros).

2. **O Controlador (`Controllers/ImcController.cs`):** O coração da funcionalidade está aqui. O controlador possui duas rotas:
   * **Mapeamento GET:** Responsável apenas por abrir a tela com o formulário limpo para o usuário.
   * **Mapeamento POST:** É aqui que a mágica acontece! Quando o usuário clica no botão "Calcular IMC", o controlador recebe os dados capturados pela tela, confere se as informações são válidas e realiza matematicamente a fórmula do IMC: `Peso / (Altura * Altura)`. Logo em seguida, ele categoriza o resultado em uma faixa (como "Peso normal", "Sobrepeso", etc.) e despacha o objeto preenchido para a página de sucesso.

3. **As Telas de Interface Visual (`Views/Imc/`):**
   * **`Cadastrar.cshtml`:** Uma tela limpa e intuitiva com campos criados usando os `Tag Helpers` do .NET, exibindo avisos em vermelho caso o usuário digite algo incorreto.
   * **`Confirmacao.cshtml`:** É a página de resultado que traz um grande diferencial visual. Utilizando a flexibilidade do C# misturado ao HTML (Razor), foi criada uma **lógica de cores dinâmica com Bootstrap**. Se o resultado for saudável (peso normal) a tela se pinta de **Verde**; se indicar atenção (abaixo do peso) ela fica **Amarela**; e se apontar um alerta (sobrepeso ou obesidade), ela fica **Vermelha** automaticamente.

Toda a navegação do sistema foi centralizada no arquivo de layout principal (`_Layout.cshtml`), permitindo alternar de forma simples e rápida entre o gerenciamento de Alunos, o Catálogo de Produtos e a nova Calculadora de IMC.

### 📸 Demonstração da Aplicação Rodando

Abaixo estão os registros visuais da aplicação processando as diferentes faixas de classificação do IMC com suas respectivas cores dinâmicas de alerta:

#### 🟢 1. Peso Normal (Interface em Verde)
![Resultado IMC - Peso Normal](images/normal.png)

#### 🟡 2. Abaixo do Peso (Interface em Amarelo)
![Resultado IMC - Abaixo do Peso](images/baixo.png)

#### 🔴 3. Sobrepeso / Obesidade (Interface em Vermelho)
![Resultado IMC - Alto risco](images/alto.png)