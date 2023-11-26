require_relative 'fan'

# Creating and configuring fan1
fan1 = Fan.new
fan1.speed = 3
fan1.radius = 10.26
fan1.color = "yellow"
puts fan1

# Creating and configuring fan2
fan2 = Fan.new(5.79)
fan2.speed = 2
fan2.color = "blue"
puts fan2

# Creating fan3 with default settings
fan3 = Fan.new
puts fan3
