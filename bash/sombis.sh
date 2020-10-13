#!/bin/bash

CharsC=( '1' '2' '3' '4' '5' '6' '7' '8' '9' )
CharsN=( '0' '1' '2' '3' '4' '5' '6' '7' '8' '9' )
CharsA=( 'A' 'C' 'D' 'E' 'F' 'G' 'H' 'J' 'K' 'M' 'N' 'P' 'Q' 'R' 'T' 'U' 'V' 'W' 'X' 'Y' )
CharsAN=( 'A' 'C' 'D' 'E' 'F' 'G' 'H' 'J' 'K' 'M' 'N' 'P' 'Q' 'R' 'T' 'U' 'V' 'W' 'X' 'Y' '0' '1' '2' '3' '4' '5' '6' '7' '8' '9')

#echo -n "CharsC: "; for item in ${CharsC[*]}; do echo -n $item; done; echo ""
#echo -n "CharsN: "; for item in ${CharsN[*]}; do echo -n $item; done; echo ""
#echo -n "CharsA: "; for item in ${CharsA[*]}; do echo -n $item; done; echo ""
#echo -n "CharsAN: "; for item in ${CharsAN[*]}; do echo -n $item; done; echo ""

# assume 80x25
SCREENCOLS=80
SCREENROWS=25

OUTPUTCOLS=$((($SCREENCOLS - 2) / 12))
OUTPUTROWS=$(($SCREENROWS - 2))

for (( i = 1; i <= $OUTPUTROWS; i++ ))
do

    for (( j = 1 ; j <= $OUTPUTCOLS; j++ ))
    do

MBI=${CharsC[$RANDOM % ${#CharsC[@]}]}\
${CharsA[$RANDOM % ${#CharsA[@]}]}\
${CharsAN[$RANDOM % ${#CharsAN[@]}]}\
${CharsN[$RANDOM % ${#CharsN[@]}]}\
${CharsA[$RANDOM % ${#CharsA[@]}]}\
${CharsAN[$RANDOM % ${#CharsAN[@]}]}\
${CharsN[$RANDOM % ${#CharsN[@]}]}\
${CharsA[$RANDOM % ${#CharsA[@]}]}\
${CharsA[$RANDOM % ${#CharsA[@]}]}\
${CharsN[$RANDOM % ${#CharsN[@]}]}\
${CharsN[$RANDOM % ${#CharsN[@]}]}

echo -n "$MBI "

    done

  echo "" 
done


