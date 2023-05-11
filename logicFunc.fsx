let compare x y = 
    if x = y then $"{x} x is equal to y {y}"
    elif x < y then $"{x} is less than y {y}"
    else $"{x} is greater than {y}"

compare 10 10