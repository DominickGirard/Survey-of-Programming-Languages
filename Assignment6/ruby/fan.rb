class Fan
  attr_accessor :speed, :radius, :color

  # Default constructor
  def initialize(radius = 1.53, speed = 1, color = "green")
    @speed = speed
    @radius = radius
    @color = color
  end

  # Method to return a string description of the fan
  def to_s
    "A #{@radius.round(2)} inch #{@color} fan at a speed of #{@speed}"
  end
end
