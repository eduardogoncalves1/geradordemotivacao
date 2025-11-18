/* style.css */

/* Define as variáveis de cores para facilitar a customização */
:root {
    --background-gradient: linear-gradient(135deg, #89cff0 0%, #b19cd9 100%); /* Gradiente de azul celeste para lilás */
    --card-background: rgba(255, 255, 255, 0.15);
    --text-color: #ffffff;
    --button-background: #ffffff;
    --button-text-color: #5a7bad; /* Tom de azul para o texto do botão */
    --shadow-color: rgba(0, 0, 0, 0.1);
}

/* Estilos gerais para o corpo da página */
body {
    margin: 0;
    font-family: 'Poppins', sans-serif;
    color: var(--text-color);
    background: var(--background-gradient);
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
    padding: 20px;
    box-sizing: border-box;
}

/* Container principal */
.container {
    text-align: center;
}

/* Estilo do "cartão" que contém a mensagem */
.card {
    background: var(--card-background);
    backdrop-filter: blur(10px); /* Efeito de vidro fosco */
    border-radius: 20px;
    padding: 40px;
    max-width: 600px;
    width: 100%;
    box-shadow: 0 8px 32px 0 var(--shadow-color);
    border: 1px solid rgba(255, 255, 255, 0.18);
}

/* Título principal */
h1 {
    font-weight: 600;
    font-size: 2.2rem;
    margin-bottom: 30px;
}

/* Container da citação */
.quote-container {
    margin: 0;
    border-left: 4px solid var(--text-color);
    padding-left: 20px;
    min-height: 100px; /* Garante uma altura mínima para não "pular" */
    display: flex;
    align-items: center;
}

/* Texto da citação */
#quote-text {
    font-size: 1.5rem;
    font-weight: 300;
    line-height: 1.6;
    transition: opacity 0.5s ease-in-out; /* Efeito suave de transição */
}

/* Botão para gerar nova mensagem */
#new-quote-btn {
    margin-top: 30px;
    padding: 15px 30px;
    border: none;
    border-radius: 50px;
    background-color: var(--button-background);
    color: var(--button-text-color);
    font-size: 1rem;
    font-weight: 600;
    cursor: pointer;
    transition: transform 0.2s ease, box-shadow 0.2s ease;
}

/* Efeito ao passar o mouse sobre o botão */
#new-quote-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.2);
}

/* --- Responsividade para Dispositivos Móveis --- */
@media (max-width: 768px) {
    .card {
        padding: 30px;
    }

    h1 {
        font-size: 1.8rem;
    }

    #quote-text {
        font-size: 1.2rem;
    }

    #new-quote-btn {
        padding: 12px 25px;
    }
}
