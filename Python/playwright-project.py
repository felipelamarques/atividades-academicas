from playwright.sync_api import sync_playwright

with sync_playwright() as p:
    browser = p.chromium.launch(headless=False)
    page = browser.new_page()
    page.goto("http://www.google.com.br")
# Digitar 'Corinthians' na barra de pesquisa
    page.fill("textarea[name='q']", 'Corinthians')
# CLicar no botão de pesquisa
    page.click("input[name='btnK']")
# Espera 5000 milisegundos
    page.wait_for_timeout(5000)
# Trazer o título da página aberta
    print(page.title())
    browser.close()
