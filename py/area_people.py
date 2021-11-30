import area

# numero de pessoas por metro quadrado em média
PEOPLE_PER_SQUARE_METER = 2
LENGTH = 240  # em metros
WIDTH = 45  # em metros
PEOPLE_AT_CONCERT = area.rectangle(LENGTH, WIDTH) // PEOPLE_PER_SQUARE_METER


print("Estão presentes no show aproximadamente", PEOPLE_AT_CONCERT, "pessoas")
