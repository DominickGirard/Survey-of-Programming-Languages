#ifndef FAN_H
#define FAN_H

#include <string>

class Fan {
public:
    Fan(); // Default constructor
    Fan(double newRadius); // Constructor with radius parameter

    std::string toString() const; // Method to return a string description of the fan

    // Accessors
    int getSpeed() const;
    double getRadius() const;
    std::string getColor() const;

    // Mutators
    void setSpeed(int speed);
    void setRadius(double radius);
    void setColor(std::string color);

private:
    int speed;
    double radius;
    std::string color;
};

#endif
