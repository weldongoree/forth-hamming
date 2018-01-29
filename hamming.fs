\ Hamming.fs
\ Hamming distance for ANSI forth
\ Currently limited to byte strings

: strlen= ( c-addr u c-addr u -- f )
  nip = nip
;

: byte-hamming ( c-addr u c-addr u -- u )
  2over 2over strlen= 0= if throw then
  rot drop
  0 swap 
  0 do   
    rot rot 
    over i chars + c@ 
    over i chars + c@ \ count addr-1 addr-2 char-1 char-2
    = if 0 else 1 then
    >r rot r> + \ addr-1 addr-2 count
  loop
  nip nip
;

: hamming ( c-addr u c-addr u xt -- u )

;
