<nav>
	
	<ul>
		<?php
			for ($i=1; $i <= 5 ; $i++) { 
				echo '<li><a href="?nav='.$i.'">Menu '.$i.'</a></li>';
			}
		?>
	</ul>

</nav>