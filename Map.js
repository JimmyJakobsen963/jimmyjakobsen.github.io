class Map {
    constructor(tileSheet, world,) {
        this.tileSheet = tileSheet;
        this.world = world;
        this.tilesCache = [];
    }

    render() {
        for (let index = this.world.map.length - 1; index > -1; index--) {
            let value = this.world.map[index];

			let sourceX = (value % this.tileSheet.columns) * this.tileSheet.tileWidth;
			let sourceY = floor(value / this.tileSheet.columns) * this.tileSheet.tileHeight;

			let destinationX = (index % this.world.columns) * this.tileSheet.tileWidth;
			let destinationY = floor(index / this.world.columns) * this.tileSheet.tileHeight;

            let i = this.getTileImage(sourceX, sourceY);
            image(i, destinationX, destinationY);
        }
    }

    getTileImage(sourceX, sourceY) {
        if (this.tilesCache[sourceX] && this.tilesCache[sourceX][sourceY]) {
            return this.tilesCache[sourceX][sourceY];
        }

        const tileImage = tileSheet.image.get(
            sourceX, sourceY,
			this.tileSheet.tileWidth, this.tileSheet.tileHeight);
		console.log(tileImage);
        if (!this.tilesCache[sourceX]) this.tilesCache[sourceX] = [];
        this.tilesCache[sourceX][sourceY] = tileImage;
        return tileImage;
    }
}