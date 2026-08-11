/* Reset e configuracoes gerais */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Segoe UI', system-ui, -apple-system, sans-serif;
    line-height: 1.7;
    color: #1a2a3a;
    background-color: #f7f9fc;
}

.container {
    max-width: 1100px;
    margin: 0 auto;
    padding: 0 24px;
}

/* Cabecalho */
.header {
    background-color: #0d2b4e;
    color: white;
    padding: 18px 0;
    position: sticky;
    top: 0;
    z-index: 100;
    box-shadow: 0 2px 10px rgba(0,0,0,0.15);
}

.header .container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    flex-wrap: wrap;
    gap: 16px;
}

.logo h1 {
    font-size: 1.5rem;
    font-weight: 700;
    letter-spacing: -0.5px;
}

.logo span {
    font-size: 0.8rem;
    opacity: 0.85;
    display: block;
    margin-top: -2px;
}

.nav ul {
    list-style: none;
    display: flex;
    gap: 8px;
    flex-wrap: wrap;
}

.nav a {
    color: #d0e0f5;
    text-decoration: none;
    font-size: 0.9rem;
    padding: 6px 12px;
    border-radius: 4px;
    transition: background 0.2s, color 0.2s;
}

.nav a:hover {
    background-color: rgba(255,255,255,0.12);
    color: white;
}

/* Hero / Inicio */
.hero {
    background: linear-gradient(135deg, #0d2b4e 0%, #1a4a7a 100%);
    color: white;
    padding: 70px 0 80px;
}

.hero h2 {
    font-size: 2.2rem;
    margin-bottom: 20px;
    font-weight: 700;
}

.abstract {
    font-size: 1.15rem;
    max-width: 800px;
    opacity: 0.95;
    margin-bottom: 40px;
}

.objetivos {
    background: rgba(255,255,255,0.1);
    padding: 28px 32px;
    border-radius: 10px;
    max-width: 700px;
}

.objetivos h3 {
    margin-bottom: 16px;
    font-size: 1.2rem;
}

.objetivos ul {
    padding-left: 22px;
}

.objetivos li {
    margin-bottom: 8px;
}

/* Secoes gerais */
.section {
    padding: 70px 0;
}

.section.alt {
    background-color: #eef3f9;
}

.section h2 {
    font-size: 1.8rem;
    color: #0d2b4e;
    margin-bottom: 24px;
    padding-bottom: 12px;
    border-bottom: 3px solid #3a7ab8;
    display: inline-block;
}

.section h3 {
    font-size: 1.25rem;
    color: #1a4a7a;
    margin: 28px 0 12px;
}

.section p {
    margin-bottom: 16px;
    max-width: 900px;
}

/* Timeline */
.timeline {
    margin-top: 30px;
    display: grid;
    gap: 20px;
}

.timeline-item {
    background: white;
    padding: 20px 24px;
    border-radius: 8px;
    border-left: 5px solid #3a7ab8;
    box-shadow: 0 2px 8px rgba(0,0,0,0.05);
}

.timeline-item strong {
    color: #0d2b4e;
    display: block;
    margin-bottom: 6px;
    font-size: 1.05rem;
}

/* Destaque */
.destaque {
    background: #e3f0ff;
    border-left: 5px solid #2a6cb0;
    padding: 18px 22px;
    margin: 28px 0;
    border-radius: 0 8px 8px 0;
    max-width: 750px;
}

/* Cards de tipos */
.cards {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(240px, 1fr));
    gap: 22px;
    margin-top: 30px;
}

.card {
    background: white;
    padding: 26px 22px;
    border-radius: 10px;
    box-shadow: 0 3px 12px rgba(0,0,0,0.06);
    border-top: 4px solid #3a7ab8;
    transition: transform 0.2s, box-shadow 0.2s;
}

.card:hover {
    transform: translateY(-4px);
    box-shadow: 0 8px 20px rgba(0,0,0,0.1);
}

.card h3 {
    margin-top: 0;
    font-size: 1.15rem;
    color: #0d2b4e;
}

/* Lista de evidencias */
.lista-evidencias {
    margin-top: 20px;
    padding-left: 22px;
}

.lista-evidencias li {
    margin-bottom: 12px;
}

/* Grid de cuidados */
.cuidados-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(230px, 1fr));
    gap: 22px;
    margin-top: 28px;
}

.cuidado-item {
    background: white;
    padding: 24px 20px;
    border-radius: 10px;
    box-shadow: 0 3px 10px rgba(0,0,0,0.05);
}

.cuidado-item h3 {
    margin-top: 0;
    color: #0d2b4e;
    font-size: 1.1rem;
}

/* Rodape */
.footer {
    background-color: #0d2b4e;
    color: #c8d8eb;
    padding: 40px 0;
    text-align: center;
    font-size: 0.95rem;
}

.footer p {
    margin-bottom: 12px;
    max-width: 800px;
    margin-left: auto;
    margin-right: auto;
}

.footer strong {
    color: #ffffff;
}

/* Responsividade */
@media (max-width: 768px) {
    .header .container {
        flex-direction: column;
        align-items: flex-start;
    }

    .nav ul {
        gap: 4px;
    }

    .nav a {
        font-size: 0.85rem;
        padding: 5px 10px;
    }

    .hero h2 {
        font-size: 1.7rem;
    }

    .hero {
        padding: 50px 0 60px;
    }

    .section {
        padding: 50px 0;
    }
}