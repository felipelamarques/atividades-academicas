import pyodbc

# usuário: sa
# senha: Admin1234
# número da porta: 8391
# certificado ssl: CN=pc-b450m; CN=192.168.15.13
# nó mestre: https://pc-b450m:8391

# Configurações de conexão
server = 'PC-B450M'  # Pode ser um endereço IP ou o nome do servidor
serverdoor = '8391'
database = 'ampereti_db'
username = 'sa'
password = 'Admin1234'

# String de conexão
sqlconnection_string = (
    f'DRIVER={{ODBC Driver 17 for SQL Server}};'
    f'SERVER={server};'
    f'DATABASE={database};'
    f'UID={username};'
    f'PWD={password}'
)

#Conectando ao SQL Server
sqlconnection = pyodbc.connect(sqlconnection_string)
print("Conexão Bem Sucedida")

#Criando cursor para executar comandos SQL
#cursor = sqlconnection.cursor()

#variável para receber o comando em SQL
#sqlcommand = """INSERT INTO tb01(NOME) VALUES('Ingrid Lacerda')"""

#executa o comando da variável 'sqlcommand'
#cursor.execute(sqlcommand)
#cursor.commit() #Só é usado se o 'sqlcommand' edita, criar ou deletar uma nova informação ou tabela