def swap_case(s):
    # define a new string
    new_string = ""
    # loop through the string
    for i in s:
        # check if the character is uppercase
        if i.isupper():
            # if it is, convert to lowercase
            new_string += i.lower()
        # if it is neither, add the character to the new string
        else:
            new_string += i.upper()
    return new_string

if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)