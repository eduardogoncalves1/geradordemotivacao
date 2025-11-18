// script.js

document.addEventListener('DOMContentLoaded', () => {
    // Array com as mensagens motivacionais
    const quotes = [
        "Acredite que você pode, assim você já está no meio do caminho.",
        "O único lugar onde o sucesso vem antes do trabalho é no dicionário.",
        "Não espere por oportunidades extraordinárias. Agarre ocasiões comuns e as faça grandes.",
        "Sua atitude, não sua aptidão, determinará sua altitude.",
        "A persistência realiza o impossível.",
        "O futuro pertence àqueles que acreditam na beleza de seus sonhos.",
        "Comece onde você está. Use o que você tem. Faça o que você pode.",
        "A vida é 10% o que acontece com você e 90% como você reage a isso.",
        "Para ter sucesso, seu desejo de sucesso deve ser maior que seu medo do fracasso.",
        "Um dia de cada vez, que é para não perder as boas surpresas da vida."
    ];

    // Seleciona os elementos do HTML
    const quoteTextElement = document.getElementById('quote-text');
    const newQuoteBtn = document.getElementById('new-quote-btn');

    // Função para gerar e exibir uma nova mensagem
    function generateNewQuote() {
        // Escolhe um índice aleatório do array de mensagens
        const randomIndex = Math.floor(Math.random() * quotes.length);
        const randomQuote = quotes[randomIndex];

        // Adiciona um efeito de fade-out
        quoteTextElement.style.opacity = 0;

        // Espera a transição terminar para trocar o texto e dar fade-in
        setTimeout(() => {
            quoteTextElement.textContent = randomQuote;
            quoteTextElement.style.opacity = 1;
        }, 500); // O tempo deve ser igual ao da transição no CSS
    }

    // Adiciona o evento de clique ao botão
    newQuoteBtn.addEventListener('click', generateNewQuote);
});
