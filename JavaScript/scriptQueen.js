let queenPositionLin = 4;
let queenPositionCol = 4;

let pcPositionLin = 2;
let pcPositionCol = 1;

let sucessAtack = false;

if((queenPositionLin == pcPositionLin)||(queenPositionCol==pcPositionCol)){
  sucessAtack = true;
}else{
  for (let supDir = 1; supDir < 8; supDir++) {
    let queenLin = queenPositionLin + supDir;
    let queenCol = queenPositionCol + supDir;
    
    if((pcPositionLin == queenLin)&&(pcPositionCol == queenCol)){
      sucessAtack = true;
    }
  }
}


console.log(sucessAtack);