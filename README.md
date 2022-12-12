# Heranca e Interface em CSharp
Exemplo de utilização de interface em C#

A interface funciona como um "contrato" de que define um determinado conjunto de métodos que devem ser implementados pelas classe que "assinarem" esse contrato.
Isso padroniza a assinatura dos métodos, sendo que somente a assinatura dos métodos é definida no corpo de uma interface, sendo que esse métodos não aceitam 
modificadores de acesso. Uma interface só pode conter indexadores, propriedades e eventos, e por convenção o nome de uma interface sempre inicia com o prefixo "I".
Todas as subclasses que herdarem a interface devem obrigatóriamente implementar seu conteúdo. 
O uso de interfaces está ligada diretamente ao polimorfismo, pois podemos aproveitar os objetos criados a partir das classes que herdam diretamente ou indiretamente 
da interface.
A interface se torna mais viável que herança em alguns pontos, principlamente onde não exite o polimorfismo entre os tipos de objetos, e que se aplicado apenas a herança,
pode gerar certa confusão entre os tipos. A interface resolve esse problema intermediando esses objetos que até então não possuiam o polimorfismo. 
