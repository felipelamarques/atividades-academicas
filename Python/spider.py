import scrapy

class MainSpider(scrapy.Spider):
    name = 'main-spider'
    start_urls = ['https://quotes.toscrape.com/']

    def parse(self, response):
        self.log('Eu estou aqui {}'.format(response.url))



