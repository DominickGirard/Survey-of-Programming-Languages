#include <iostream>
#include "Fan.h"

Fan::Fan() {
    setSpeed(1);
    setRadius(1.53);
    setColor("green");
}

Fan::Fan(double newRadius) {
    setRadius(newRadius);
}

std::string Fan::toString() const {
    char buffer[100];
    sprintf_s(buffer, "A %.2f inch %s fan at a speed of %d", getRadius(), getColor().c_str(), getSpeed());
    return std::string(buffer);
}

int Fan::getSpeed() const {
    return speed;
}

void Fan::setSpeed(int newSpeed) {
    speed = newSpeed;
}

double Fan::getRadius() const {
    return radius;
}

void Fan::setRadius(double newRadius) {
    radius = newRadius;
}

std::string Fan::getColor() const {
    return color;
}

void Fan::setColor(std::string newColor) {
    color = newColor;
}

int main() {
    // Creating and configuring fan1
    Fan fan1;
    fan1.setSpeed(3);
    fan1.setRadius(10.26);
    fan1.setColor("yellow");
    std::cout << fan1.toString() << std::endl;

    // Creating and configuring fan2
    Fan fan2(5.79);
    fan2.setSpeed(2);
    fan2.setColor("blue");
    std::cout << fan2.toString() << std::endl;

    // Creating fan3 with default settings
    Fan fan3;
    std::cout << fan3.toString() << std::endl;

    return 0;
}
