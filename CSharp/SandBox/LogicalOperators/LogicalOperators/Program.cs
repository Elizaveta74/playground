// Logical AND

// to simulate a situation where there's an item available in the shop
// and we have enough money to buy this item (and we want to buy this item)

bool doWeNeedThisItem = true;
bool isItemAvailable = true;
bool isEnoughMoney = true;

// Please note that for the && operator, all operands must be true to evaluate to true
if (doWeNeedThisItem && isItemAvailable && isEnoughMoney)
{
    // let's buy that item
}


// Logical OR

// Simulate another situation where there are some tasty things in the fridge.

bool iceCreamInTheFridge = true;
bool cakeInTheFridge = true;
bool fruitsInTheFridge = true;

if (iceCreamInTheFridge || cakeInTheFridge || fruitsInTheFridge)
{
    // when ice cream or cake or fruit is in the fridge
    // let's eat them
}

// Logical NOT

bool isDrivewayClosed = false;

if (!isDrivewayClosed)
{
    // If the driveway isn't closed, we're on our way.
}

// ----------------------------------------------------------------------------------------------------------------

/**
 * Function 1
 * 
 * Write a function that takes three integer arguments, a, b, and c, and returns true if b is in the range (a; c].
 * For example range (10; 15] means that 10 is not included in the range, but 15 is included (check the round and square brackets).
 */

/**
 * Function 2
 * 
 * Write a function that takes two integer arguments and returns true if both arguments are greater than zero.
 */

/**
 * Function 3
 * 
 * Write a function that takes two arguments a and b of type bool and returns true if one argument has a value opposite to the other. 
 * For example - one of them is true and the other is false.
 */

// ----------------------------------------------------------------------------------------------------------------