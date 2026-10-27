const canvas = document.getElementById('gameCanvas');
const ctx = canvas.getContext('2d');
const placarElement = document.getElementById('placar');

var gravity = 0.1; 
var score = 0;
var highscore = 0;

var keys = {
    a: false, d: false,
    ArrowLeft: false, ArrowRight: false
};

window.addEventListener('keydown', function(e) {
    if (e.key in keys) keys[e.key] = true;
});

window.addEventListener('keyup', function(e) {
    if (e.key in keys) keys[e.key] = false;
});

class Platform {
    constructor(x, y, color, controls) {
        this.x = x;
        this.y = y;
        this.width = 120;
        this.height = 15;
        this.color = color;
        this.controls = controls;
        this.speed = 6;
    }

    update() {
        if (keys[this.controls.left]) this.x -= this.speed;
        if (keys[this.controls.right]) this.x += this.speed;

        if (this.x < 0) this.x = 0;
        if (this.x + this.width > canvas.width) this.x = canvas.width - this.width;
    }

    draw() {
        ctx.fillStyle = this.color;
        ctx.fillRect(this.x, this.y, this.width, this.height);
    }
}

class Target {
    constructor() {
        this.radius = 12;
        this.color = 'yellow';
        this.reset();
    }

    reset() {
        this.x = Math.random() * (canvas.width - 100) + 50;
        this.y = Math.random() * 150 + 50; 
    }

    draw() {
        ctx.beginPath();
        ctx.arc(this.x, this.y, this.radius, 0, Math.PI * 2);
        ctx.fillStyle = this.color;
        ctx.fill();
        ctx.closePath();
    }
}

class Ball {
    constructor() {
        this.radius = 10;
        this.color = 'white';
        this.reset();
    }

    reset() {
        this.x = canvas.width / 2;
        this.y = 100;
        this.vx = Math.random() > 0.5 ? 3 : -3;
        this.vy = 0;
    }

    update() {
        this.vy += gravity;
        this.x += this.vx;
        this.y += this.vy;

        if (this.x - this.radius < 0 || this.x + this.radius > canvas.width) {
            this.vx = -this.vx;
        }

        if (this.y - this.radius < 0) {
            this.y = this.radius;
            this.vy = -this.vy;
        }

        if (this.y - this.radius > canvas.height) {
            if (score > highscore) highscore = score;
            score = 0;
            placarElement.innerText = 'Pontos: ' + score + ' | Recorde: ' + highscore;
            this.reset();
        }
    }

    draw() {
        ctx.beginPath();
        ctx.arc(this.x, this.y, this.radius, 0, Math.PI * 2);
        ctx.fillStyle = this.color;
        ctx.fill();
        ctx.closePath();
    }
}

var p1 = new Platform(150, canvas.height - 40, 'cyan', { left: 'a', right: 'd' });
var p2 = new Platform(550, canvas.height - 40, 'red', { left: 'ArrowLeft', right: 'ArrowRight' });
var bola = new Ball();
var estrela = new Target();

function colisaoPlataforma(b, p) {
    return b.x + b.radius > p.x &&
           b.x - b.radius < p.x + p.width &&
           b.y + b.radius > p.y &&
           b.y - b.radius < p.y + p.height;
}

function colisaoEstrela(b, t) {
    var dx = b.x - t.x;
    var dy = b.y - t.y;
    var dist = Math.sqrt(dx * dx + dy * dy);
    return dist < b.radius + t.radius;
}

function animate() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    p1.update();
    p2.update();
    bola.update();

    if (colisaoPlataforma(bola, p1) && bola.vy > 0) {
        bola.vy = -8.5;
        bola.vx = (bola.x - (p1.x + p1.width / 2)) * 0.15;
    }

    if (colisaoPlataforma(bola, p2) && bola.vy > 0) {
        bola.vy = -8.5;
        bola.vx = (bola.x - (p2.x + p2.width / 2)) * 0.15;
    }

    if (colisaoEstrela(bola, estrela)) {
        score++;
        placarElement.innerText = 'Pontos: ' + score + ' | Recorde: ' + highscore;
        estrela.reset();
        bola.vy = -3;
    }

    estrela.draw();
    p1.draw();
    p2.draw();
    bola.draw();

    requestAnimationFrame(animate);
}

animate();