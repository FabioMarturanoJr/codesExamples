import pytest
# get_most_ordered_dish_per_costumer é uma função que retorna o prato mais
# pedido por uma determinada pessoa cliente, considerando que os pedidos estão
# em uma lista.

# get_order_frequency_per_costumer é uma função que retorna a frequência que
# uma determinada pessoa cliente pede um determinado prato , considerando que 
# os pedidos estão em uma lista.


# uma fixture utilizando a biblioteca pytest
# é definida utilizando a sintaxe abaixo
@pytest.fixture
def orders():
    """Nosso cenário (contexto) temos os seguintes pedidos"""
    return [
        {"customer": "maria", "order": "pizza", "day": "terça-feira"},
        {"customer": "joao", "order": "hamburger", "day": "terça-feira"},
        {"customer": "maria", "order": "pizza", "day": "quarta-feira"},
        {"customer": "maria", "order": "hamburger", "day": "quinta-feira"},
    ]


# estamos adicionando a fixture orders ao teste
# ou seja temos um contexto onde os pedidos são os definidos anteriormente
def test_get_most_ordered_dish_per_costumer_when_customer_is_maria(orders):
    assert get_most_ordered_dish_per_costumer(orders, "maria") == "pizza"


# novamente adicionamos um cenário (contexto) ao teste onde os pedidos realizados são os
# definidos na fixture
def test_get_order_frequency_per_costumer_when_customer_is_joao_and_order_is_pizza(orders):
    assert get_order_frequency_per_costumer(orders, "joao", "pizza") == 0


def test_get_order_frequency_per_costumer_when_customer_is_maria_and_order_is_hamburger(orders):
    assert get_order_frequency_per_costumer(orders, "maria", "hamburger") == 1
