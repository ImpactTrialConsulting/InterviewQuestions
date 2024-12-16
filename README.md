# Question 1 - Customs Forms
Imagine you work at customs at San Francisco International Airport.  Your job is to process customs declaration forms, which are distributed to all passengers on flights inbound from other countries.

The form asks a series of 26 yes-or-no questions marked a through z. On a slip of paper, passengers identify the questions for which they answered "yes".  For example:

> `abcx`

indicates a passenger answered "yes" to four questions: a, b, c, and x.

Groups of passengers collect their slips together and present them to you in a batch.  For example, in this group:

> `abcx`
> 
> `abcy`
> 
> `abcz`

there are 6 questions to which anyone in the group answered "yes": a, b, c, x, y, and z.  Duplicate answers to the same question don't count extra; each question counts at most once.

One by one, groups present their collections of slips to you.  Eventually you've collected answers from every group on the plane.  Each group's answers are separated by a blank line, and within each group, each person's answers are on a single line.  For example:

```
abc

a
b
c

ab
ac

a
a
a
a

b
```

This list represents answers from five groups:
- The first group contains one person who answered "yes" to 3 questions: a, b, and c.
- The second group contains three people; combined, they answered "yes" to 3 questions: a, b, and c.
- The third group contains two people; combined, they answered "yes" to 3 questions: a, b, and c.
- The fourth group contains four people; combined, they answered "yes" to only 1 question, a.
- The last group contains one person who answered "yes" to only 1 question, b.

In this example, the sum of these counts is 3 + 3 + 3 + 1 + 1 = 11.

For each group, count the number of questions to which anyone answered "yes".  **What is the sum of those counts?**

You should expect ~400 groups in your input.