def main():
    # creating a tuple.
    my_tuple = (1, 2, 3, 4, 5)
    print("Tuple:", my_tuple)

    # checking out some elements in the tuple.
    print("First element:", my_tuple[0])
    print("Last element:", my_tuple[-1])

    # Can't edit a tuple, uncommenting this will throw an error.
    # my_tuple[0] = 10

    #creating a list.
    my_list = [10, 20, 30, 40, 50]
    print("\nList:", my_list)

    # Accessing elements in a list is similar to a tuple.
    print("First element:", my_list[0])
    print("Last element:", my_list[-1])

    # I can change a list.
    my_list[0] = 100
    print("\nModified List:", my_list)

    # add something to the list.
    my_list.append(60)
    print("List after appending 60:", my_list)

    # Extending a list with another list.
    extension_list = [70, 80, 90]
    my_list.extend(extension_list)
    print("List after extending with another list:", my_list)

    # Remove an element from the list.
    my_list.remove(40)
    print("List after removing 40:", my_list)

    # squaring my_list.
    squared_numbers = [x ** 2 for x in my_list]
    print("\nList of squared numbers:", squared_numbers)

    # Convert a tuple to a list.
    tuple_to_list = list(my_tuple)
    print("\nTuple converted to list:", tuple_to_list)

    # Convert a list back to a tuple.
    list_to_tuple = tuple(my_list)
    print("List converted to tuple:", list_to_tuple)
    
    main()