# Question 2 - Start Sequence
You will be given a sequence of random characters which represent a datastream for an imaginary protocol.  This protocol defines a start-of-packet marker as a sequence of four characters that are all different.

For example, in this datastream:

> `mjqjpqmgbljsphdztnvjfqwrcgsmlb`

the first start-of-packet marker appears after the _seventh_ character arrives.  The seventh character ends this sequence of four: `jpqm`.

Here are some more examples:
* `bvwbjplbgvbhsrlpgdmjqwftvncz`: first marker appears after character *5*
* `zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw`: first marker appears after character *11*

**How many characters need to be processed before the first start-of-packet marker is detected?**
